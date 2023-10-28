# Codility-AbsDistinct
A non-empty array A consisting of N numbers is given.</br> 
The array is sorted in non-decreasing order.</br>
The absolute distinct count of this array is the number of distinct absolute values among the elements of the array.

For example, consider array A such that:</br>
A[0] = -5</br>
A[1] = -3</br>
A[2] = -1</br>
A[3] =  0</br>
A[4] =  3</br>
A[5] =  6</br>
The absolute distinct count of this array is 5, because there are 5 distinct absolute values among the elements of this array,</br> 
namely 0, 1, 3, 5 and 6.

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given a non-empty array A consisting of N numbers, returns absolute distinct count of array A.

For example, given array A such that:</br>
A[0] = -5</br>
A[1] = -3</br>
A[2] = -1</br>
A[3] =  0</br>
A[4] =  3</br>
A[5] =  6</br>
the function should return 5, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..100,000];</br>
each element of array A is an integer within the range [−2,147,483,648..2,147,483,647];</br>
array A is sorted in non-decreasing order.
