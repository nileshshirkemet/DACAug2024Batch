#pragma once
#ifdef _WIN32
#define EXPORT __declspec(dllexport)
#else
#define EXPORT
#endif
#ifdef __cplusplus
extern "C" {
#endif

typedef unsigned long long primes_num_t;

typedef struct {
	primes_num_t start;
	int count;
}primes_range_t;

typedef int (*primes_selector_t)(primes_num_t);

EXPORT int primes_count(primes_num_t first, primes_num_t last);
EXPORT primes_num_t primes_fetch(const primes_range_t* range, primes_num_t* store, primes_selector_t select);

#ifdef __cplusplus
}
#endif

