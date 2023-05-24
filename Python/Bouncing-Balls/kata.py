def bouncing_ball(h, bounce, window):
    if h <= 0 or window >= h or bounce < 0 or bounce > 1:
        return -1
    
    times_seen = 1
    
    while h*bounce > window:
        times_seen += 2
        h *= bounce
        
    return times_seen