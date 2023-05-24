def number(bus_stops):
    total = 0
    
    for entered, left in bus_stops:
        total += entered - left
        
    return total
