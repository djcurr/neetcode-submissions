type StockSpanner struct {
    History [][2]int
}

func Constructor() StockSpanner {
    return StockSpanner{make([][2]int, 0)}
}

func (this *StockSpanner) Next(price int) int {
    out := 1
    for len(this.History) > 0 && price >= this.History[len(this.History) - 1][0] {
        out += this.History[len(this.History) - 1][1]
        this.History = this.History[:len(this.History) - 1]
    }

    this.History = append(this.History, [2]int{price, out})
    
    return out
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * obj := Constructor()
 * param1 := obj.Next(price)
 */
 