def permutations(s):
    if len(s) == 1:
        return s

    recursive_perms = []
    for c in s:
        for perm in permutations(s.replace(c,'',1)):
            recursive_perms.append(c+perm)

    return set(recursive_perms)