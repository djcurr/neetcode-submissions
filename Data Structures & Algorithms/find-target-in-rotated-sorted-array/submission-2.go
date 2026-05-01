func search(nums []int, target int) int {
	if len(nums) == 0 {
		return -1
	}
	split := part(nums, 0, len(nums) - 1)
	if split == -1 {
		return b(nums, 0, len(nums)-1, target)
	}
	if target < nums[0] {
		return b(nums, split + 1, len(nums) - 1, target)
	} else {
		return b(nums, 0, split, target)
	}
}

func b(nums []int, start int, end int, target int) int {
	if start > end {
		return -1
	}
	mid := (start + end) / 2
	if nums[mid] == target {
		return mid
	} else if nums[mid] < target {
		return b(nums, mid + 1, end, target)
	} else {
		return b(nums, start, mid-1, target)
	}
}

func part(nums []int, start int, end int) int {
	if start >= end || nums[start] <= nums[end] {
		return -1
	}
	mid := (start + end) / 2
	if mid < end && nums[mid] > nums[mid+1] {
		return mid
	}
	if mid > start && nums[mid-1] > nums[mid] {
		return mid -1
	}
	if nums[mid] >= nums[start] {
		return part(nums, mid + 1, end)
	} else {
		return part(nums, start, mid-1)
	}
}
