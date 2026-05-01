func majorityElement(nums []int) []int {
    if len(nums) == 0 {
        return nil
    }
    freq := make(map[int]int)
    out := make([]int, 0)
    target := len(nums) / 3
    for _, n := range nums {
        freq[n]++
    }
    for n, count := range freq {
        if count > target {
            out = append(out, n)
        }
    }
    return out
}
