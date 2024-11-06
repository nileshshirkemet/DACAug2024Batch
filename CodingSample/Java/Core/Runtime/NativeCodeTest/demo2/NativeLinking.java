
import java.lang.invoke.MethodHandle;
import java.lang.invoke.MethodHandles;
import java.lang.foreign.SymbolLookup;
import java.lang.foreign.Linker;
import java.lang.foreign.FunctionDescriptor;
import java.lang.foreign.Arena;
import java.lang.foreign.MemoryLayout;
import java.lang.foreign.MemorySegment;


class NativeLinking {

	public static MethodHandle importFunction(SymbolLookup lookup, String func, MemoryLayout result, MemoryLayout... parameters) {
		if(lookup == null)
			lookup = SymbolLookup.loaderLookup();
		return Linker.nativeLinker().downcallHandle(
			lookup.find(func).get(), FunctionDescriptor.of(result, parameters));
	}
	
	public static MemorySegment exportMethod(Arena scope, Object target, String method, MemoryLayout result, MemoryLayout... parameters) {
		if(scope == null)
			scope = Arena.global();
		var fd = FunctionDescriptor.of(result, parameters);
		try{
			if(target instanceof Class<?> targetClass){
				var mh = MethodHandles.lookup().findStatic(targetClass, method, fd.toMethodType());
				return Linker.nativeLinker().upcallStub(mh, fd, scope);
			}
			var mh = MethodHandles.lookup().findVirtual(target.getClass(), method, fd.toMethodType());
			return Linker.nativeLinker().upcallStub(mh.bindTo(target), fd, scope);
		}catch(Exception e){
			throw new UnsatisfiedLinkError(e.toString());
		}
	}

	private NativeLinking() {}
}

