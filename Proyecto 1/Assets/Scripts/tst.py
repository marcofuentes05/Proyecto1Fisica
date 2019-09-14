import sys
import os
import numpy as np
import matplotlib.pyplot as plt
x = sys.argv[1]
y = sys.argv[2]
# print concatenated parameters
#print(x+y)
time = np.array([1,2,3,4,5,6,7,8,9,10])
position = np.array([2,4,6,8,10,12,14,16,18,20])

plt.scatter(time, position)
plt.ylabel('Posicion')
plt.xlabel('Tiempo')
plt.title('Posicion-Tiempo')

plt.savefig('Assets\\Images\\ESTASIESPRROs.png',dpi = 300)