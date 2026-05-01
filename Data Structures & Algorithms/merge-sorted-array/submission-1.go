func merge(nums1 []int, m int, nums2 []int, n int) {
	i := len(nums1) - n - 1 // 2
	j := len(nums1) - 1 // 5
	k := n - 1 // 2
	for j >= 0 {
		if i >= 0 && k >= 0 && nums1[i] > nums2[k] {
			nums1[j] = nums1[i]
			i--
		} else if k >= 0 {
			nums1[j] = nums2[k]
			k--
		}
		j--
	}
}
