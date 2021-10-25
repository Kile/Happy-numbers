def thing(number:int) -> int:
    """Returns a number based on the happy number thing"""
    n = 0
    for letter in [l for l in str(number)]:
        n += int(letter)**2 
    return n

def is_happy(number:int) -> bool:
    """Returns a bool that states wether a number is happy or not"""
    results = []
    result = thing(number)
    results.append(result)

    while results.count(result) < 2: # Checking if a number has shown up in the list of previous results again as that is      
        result = thing(result)     # the point where you can determine if the number is happy or not
        results.append(result)

    return (result == 1)


# Tests
print("Is 19 a happy number? ", "Yes" if is_happy(19) else "No") #Expected: Yes

print("Is 5 a happy number? ", "Yes" if is_happy(5) else "No") # Expected: No