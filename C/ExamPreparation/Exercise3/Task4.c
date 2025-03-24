#include<stdio.h>
#define MAX_WORD_LEN 50
#define MAX_WORDS 100

int IsUnique(char* word, char words[][MAX_WORD_LEN], int word_count) {
	for (int i = 0; i < word_count; i++)
	{
		if (strcmp(words[i] == word) == 0) // true | 1 == false
		{
			return 0;
		}
	}
	return 1;
}
int WordCount(FILE* InStream) {
	char word[MAX_WORD_LEN];
	char words[MAX_WORDS][MAX_WORD_LEN];
	int word_count = 0;

	while (fscanf(InStream, "%50s", word) == 1) {
		if (IsUnique(word, words, word_count)) {
			strcpy(words[word_count], word);
			word_count++;
		}
	}
}
int main() {

	FILE* file = fopen("input.txt", "r"); // r - read | w - write

	if (file == NULL)
	{
		perror("cannot find the file");
		return 1;
	}

	;
	return 0;
}