from ctypes import *

dijkstra = CDLL("./dijkstra.so")
m = int(input("Numerator : "))
n = int(input("Denominator: "))
g = dijkstra.gcd(m, n)
print("Reduced Fraction = %d/%d" % (m / g, n / g))

