import walkslib
import matplotlib.pyplot as plt

 
init_state = [1/walkslib.sqrt2, 1/walkslib.sqrt2]
step_number = 500

zeros = [init_state]

def run(steps, zero_prob):
    # Initialise lists.
    min, max = -500, 500
    posn = [[0, 0] for i in range(min, max)]
    posn[max] = init_state
    
    
    # Run for some steps...
    for time in range(steps):
        posn = walkslib.shift(walkslib.coin(posn))
        zero_prob.append(posn[max])
        
    if (steps % 2 == 0):
        zero_prob = zero_prob[0::2]
        zeros_range = range(0, 2*len(zero_prob), 2)
    else:
        zero_prob = zero_prob[1::2]
        zeros_range = range(1, 2*len(zero_prob), 2)
    
    zero_prob = walkslib.probabilities(zero_prob)

    # Plot.
    plt.plot(zeros_range, zero_prob)
    plt.title(init_state)
    plt.show()
    
    return zero_prob, zeros_range
    

"for i in range(1, 10):    run(i)"

run(step_number, zeros)
 