func carFleet(target int, position []int, speed []int) int {
	cars := make([][2]int, len(position))
	for i := range position {
		cars[i] = [2]int{position[i], speed[i]}
	}

	sort.Slice(cars, func(i, j int) bool {
		return cars[i][0] > cars[j][0]
	})
	stack := []float64{}

	for _, car := range cars {
		time := float64(target-car[0]) / float64(car[1])

		if len(stack) == 0 || time > stack[len(stack)-1] {
			stack = append(stack, time)
		}
	}
	return len(stack)
}
