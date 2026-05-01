type StockSpanner struct {
    History []int
}

func Constructor() StockSpanner {
    return StockSpanner{make([]int, 0)}
}

func (this *StockSpanner) Next(price int) int {
    count := 1
    for i := len(this.History) - 1; i >= 0; i-- {
        if this.History[i] <= price {
            count++
        } else {
            break
        }
    }
    this.History = append(this.History, price)
    return count
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * obj := Constructor()
 * param1 := obj.Next(price)
 */
 