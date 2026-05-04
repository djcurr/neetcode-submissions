func productExceptSelf(nums []int) []int {
	n := len(nums)
	out := make([]int, n)
	
	prefix := 1
	for i, num := range nums {
		out[i] = prefix 
		prefix = prefix * num
	}

	suffix := 1
	for i := n - 1; i >= 0; i-- {
		out[i] = suffix * out[i]
		suffix = suffix * nums[i]
	}
	return out
}
