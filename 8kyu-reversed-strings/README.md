## 8 kyu - Reversed Strings
https://www.codewars.com/kata/5168bb5dfe9a00b126000018/csharp

Reverses a string passed as input.

My solution: convert to char array, reverse with Array.Reverse, rebuild string.

Shorter alternative I'm aware of: `new string(str.Reverse().ToArray())`.
