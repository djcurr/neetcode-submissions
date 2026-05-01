func majorityElement(nums []int) []int {
    if len(nums) == 0 {
        return nil
    }
    sorted := nums
    sort.Ints(sorted)
    target := len(nums) / 3
    out := make([]int, 0)
    last, count := sorted[0], 1
    for i := 1; i < len(sorted); i++ {
        if last == sorted[i] {
            count += 1
        } else {
            if count > target {
                out = append(out, last)
            }
            last = sorted[i]
            count = 1
        }
    }
    if count > target {
        out = append(out, last)
    }
    return out
}
