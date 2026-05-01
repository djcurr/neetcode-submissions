func decodeString(s string) string {
	out := ""
	nums := []int{}
	strs := []string{}
	num := 0
	for _, ch := range s {
		if unicode.IsDigit(ch) {
			num = num*10 + int(ch-'0')
		} else if ch == '[' {
			nums = append(nums, num)
			strs = append(strs, out)
			num = 0
			out = ""
		} else if ch == ']' {
			n := nums[len(nums)-1]
			nums = nums[:len(nums)-1]
			prev := strs[len(strs)-1]
			strs = strs[:len(strs)-1]
			out = prev + strings.Repeat(out, n)
		} else {
			out += string(ch)
		}
	}
	return out
}
