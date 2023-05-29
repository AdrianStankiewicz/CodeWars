def rgb(r, g, b):
    r, g, b = [max(0, min(255, c)) for c in (r, g, b)]

    return '{:02x}{:02x}{:02x}'.format(r, g, b).upper()