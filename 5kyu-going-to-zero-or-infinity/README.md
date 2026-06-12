## 5 kyu - Going to zero or to infinity?
https://www.codewars.com/kata/55a29405bc7d2efaff00007c

My approach: instead of computing full factorials (which grow huge fast),
I noticed the expression simplifies to a sum of partial products of
reciprocals (1, 1/n, 1/(n*(n-1)), ...). My solution builds this step by
step using helper functions CalcIntFactor and AddFactors.
