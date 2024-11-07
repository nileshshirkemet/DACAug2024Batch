import static java.lang.foreign.ValueLayout.*;

import java.lang.foreign.Arena;
import java.lang.foreign.MemoryLayout;
import java.lang.foreign.MemorySegment;
import java.lang.foreign.SymbolLookup;
import java.lang.invoke.MethodHandle;

class Primes {
    
    final static SymbolLookup primesLookup = SymbolLookup.libraryLookup("bin/libprimes.so", Arena.global());

    final static MethodHandle primesCountHandle = NativeLinking.importFunction(primesLookup, "primes_count", JAVA_INT, JAVA_LONG, JAVA_LONG);

    final static MethodHandle primesFetchHandle = NativeLinking.importFunction(primesLookup, "primes_fetch", JAVA_LONG, ADDRESS, ADDRESS, ADDRESS);

    final static MemoryLayout primesRangeLayout = MemoryLayout.structLayout(JAVA_LONG, JAVA_INT);

    final static MemorySegment selectorStubSegment = NativeLinking.exportMethod(null, Primes.class, "isFavorite", JAVA_BOOLEAN, JAVA_LONG);

    static boolean isFavorite(long prime) {
        return (prime - 1) % 4 == 0;
    }

    public static int countBetween(long first, long last) {
        try{
            return (int) primesCountHandle.invoke(first, last);
        }catch(Throwable t){
            throw new RuntimeException(t);
        }
    }

    public static long[] fetchSelected(long start, int count){
        try(var arena = Arena.ofConfined()){
            var range = arena.allocate(primesRangeLayout);
            primesRangeLayout.varHandle(PathElement.groupElement(0)).set(range, 0, start);
            primesRangeLayout.varHandle(PathElement.groupElement(1)).set(range, 0, count);
            var store = arena.allocate(JAVA_LONG, count);
            //primesFetchHandle.invoke(range, store, MemorySegment.NULL);
            primesFetchHandle.invoke(range, store, selectorStubSegment);
            return store.toArray(JAVA_LONG);
        }catch(Throwable t){
            throw new RuntimeException(t);
        }
    }
}
