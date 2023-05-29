# Kata content:
In this kata, your task is to create all permutations of a non-empty input string and remove duplicates, if present.

Create as many "shufflings" as you can!
___
### Example:
With input 'a':  
Your function should return: ['a']

With input 'ab':  
Your function should return ['ab', 'ba']

With input 'abc':  
Your function should return ['abc','acb','bac','bca','cab','cba']

With input 'aabb':  
Your function should return ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']
___
Note: The order of the permutations doesn't matter.
# Provided tests:
```Py
import codewars_test as test
from solution import permutations

@test.describe("Basic Tests")
def basic_tests():
    
    @test.it("Basic Tests")
    def basic_tests():
        test.assert_equals(sorted(permutations('a')), ['a']);
        test.assert_equals(sorted(permutations('ab')), ['ab', 'ba'])
        test.assert_equals(sorted(permutations('aabb')), ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa'])
```