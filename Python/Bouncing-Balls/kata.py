import math

def bouncing_ball(h, bounce, window):
    if h <= 0 or window >= h or bounce <= 0 or bounce >= 1:
        return -1
    
    return 1 + 2*int(h*bounce > window) * math.floor(math.log(window/h, bounce))