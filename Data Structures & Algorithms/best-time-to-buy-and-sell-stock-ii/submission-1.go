func maxProfit(prices []int) int {
	minP := 100000
	out := 0
	for _, p := range prices {
		if p > minP {
			out += p - minP
			minP = p
		} else if p < minP {
			minP = p
		}
	}
	return out
}
