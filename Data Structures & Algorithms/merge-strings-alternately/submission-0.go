func mergeAlternately(word1 string, word2 string) string {
	n1 := len(word1)
	n2 := len(word2)
	out := ""
	for i := 0; i < max(n1, n2); i++ {
		if i < n1 {
			out += string(word1[i])
		}
		if i < n2 {
			out += string(word2[i])
		}
	}
	return out
}
