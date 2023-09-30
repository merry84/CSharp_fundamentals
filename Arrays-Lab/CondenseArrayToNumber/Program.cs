// Create a program to read an array of integers and condense them by summing
// all adjacent couples of elements until a single integer remains.
//For example, let us say we have 3 elements - {2, 10, 3}.
//We sum the first two and the second two elements and get {2 + 10, 10 + 3} = { 12, 13},
//then we sum all adjacent elements again. This results in {12 + 13} = { 25}.


//While we have more than one element in the array nums[], repeat the following:
//•	Allocate a new array condensed[] of size nums.length.
//•	Sum the numbers from nums[] to condensed[].
//o	condensed[i] = nums[i] + nums[i + 1]
//•	nums[] = condensed[]
//The process is illustrated below:

