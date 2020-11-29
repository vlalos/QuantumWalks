import math
import numpy as np

sqrt2 = 1/math.sqrt(2)

def probabilities(posn):
    """Returns a list of the probabilies for each place."""
    return [sum([abs(amp) ** 2 for amp in point]) for point in posn]


def normalise(posn):
    """Normalise function to normalise an input 1D line."""
    N = math.sqrt(sum(probabilities(posn)))
    return [[amp / N for amp in point] for point in posn]


def coin(posn):
    """Apply a Hadamard gate on each element."""
    return [[(x[0] + x[1])/sqrt2, (x[0] - x[1])/sqrt2] for x in posn]


def shift(coin):
    """Shift the up elements leftwards and the down elements rightwards."""
    newposn = [[0, 0] for i in range(len(coin))]
    for j in range(1, len(coin) - 1):
        newposn[j + 1][0] += coin[j][0]
        newposn[j - 1][1] += coin[j][1]
    return normalise(newposn)