from hadamard_1 import run
import matplotlib.pyplot as plt
import numpy as np

zeros = np.array([])
for i in range(0, 10):
    prob = run(i)
    np.append(zeros, [prob[250]])

print(zeros)
    