import walkslib
import matplotlib.pyplot as plt

 
init_state = [1/walkslib.sqrt2, 1j/walkslib.sqrt2]
step_number = 500

def run(steps):
    # Initialise lists.
    min, max = -500, 500
    posn = [[0, 0] for i in range(min, max)]
    posn[max] = init_state
    
    
    # Run for some steps...
    for time in range(steps):
        posn = walkslib.shift(walkslib.coin(posn))
        
    if (steps % 2 == 0):
        posn_not_null = posn[0::2]
        shown_range = range(min, max, 2)
    else:
        posn_not_null = posn[1::2]
        shown_range = range(min + 1, max, 2)
    
    shown_prob = walkslib.probabilities(posn_not_null)
    
    # Plot.
    #plt.plot(shown_range, shown_prob)
    #plt.title(init_state)
    #plt.show()
    
    return shown_prob
    

"for i in range(1, 10):    run(i)"

run(step_number)