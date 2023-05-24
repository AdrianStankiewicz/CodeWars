def duplicate_count(text):
    return len([char for char in set(text.lower()) if text.lower().count(char) > 1])
