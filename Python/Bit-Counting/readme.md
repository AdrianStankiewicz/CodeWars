# Kata content:
Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. You can guarantee that input is non-negative.  

### Example:
The binary representation of ```1234``` is ```10011010010```, so the function should return ```5``` in this case

# Provided tests:
```Py
import codewars_test as test
from solution import count_bits

@test.describe("Fixed Tests")
def fixed_tests():
    @test.it("Basic Tests")
    def basic_tests():
        test.assert_equals(count_bits(0), 0)
        test.assert_equals(count_bits(4), 1)
        test.assert_equals(count_bits(7), 3)
        test.assert_equals(count_bits(9), 2)
        test.assert_equals(count_bits(10), 2)
```