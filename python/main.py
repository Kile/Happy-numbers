def thing(number:int):
    """Returns a number based on the happy number thing"""
    n = 0
    for i in range(len(str(number))):
        n = n+[x for x in map(int, str(number))][i]**2 
    return n

def is_happy(number:int):
    """Returns a bool that states wether a number is happy or not"""
    results = []
    result = thing(number)
    results.append(result)

    while results.count(result) < 2: # Checking if a number has shown up in the list of previous results again as that is      
        result = thing(result)     # the point where you can determine if the number is happy or not
        results.append(result)

    return (result == 1)