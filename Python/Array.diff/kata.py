def array_diff(a, b):
    for e in b:
        while e in a:
            a.remove(e)
    
    return a