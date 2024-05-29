function maxSubArraySum(nums) {
    let maxSoFar = nums[0];
    let maxEndingHere = nums[0];
    
    for (let i = 1; i < nums.length; i++) {
        maxEndingHere = Math.max(nums[i], maxEndingHere + nums[i]);
        maxSoFar = Math.max(maxSoFar, maxEndingHere);
    }
    
    return maxSoFar;
}


const nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
console.log(maxSubArraySum(nums));  // output: 6
