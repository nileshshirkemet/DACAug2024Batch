#include "Entropy.h"
#include <unistd.h>
#include <fcntl.h>

JNIEXPORT jstring JNICALL Java_Entropy_captcha(JNIEnv* env, jclass cls, jint size)
{
    //jchar buffer[size];
    jchar* buffer = new jchar[size];
    jstring result;
    int fd = open("/dev/random", O_RDONLY);

    for(jint i = 0; i < size; ++i)
    {
        jchar c;
        read(fd, &c, sizeof(c));
        buffer[i] = i % 2 ? (48 + c % 10) : (65 + c % 26);
    }
    result = env->NewString(buffer, size);
    close(fd);
    delete[] buffer;
    
    return result;
}
