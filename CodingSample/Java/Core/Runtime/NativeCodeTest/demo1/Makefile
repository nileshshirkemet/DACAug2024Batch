OUTPUT		:= bin/libentropy.so
SOURCES		:= $(wildcard *.cpp)
JAVA_HOME 	?= $(shell readlink -e "$$(dirname "$$(readlink -e "$$(which javac)")")"/..)
CFLAGS  	+=  -I"$(JAVA_HOME)/include" -I"$(JAVA_HOME)/include/linux" -fPIC
LDFLAGS 	+= -shared -L. -Wl,-rpath,.

all: $(OUTPUT)

$(OUTPUT): $(SOURCES)
	@$(CXX) $(CFLAGS) $(LDFLAGS) $? -o $@


