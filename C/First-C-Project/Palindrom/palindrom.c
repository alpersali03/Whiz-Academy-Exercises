#include <stdio.h>
#include <string.h>
#include <stdbool.h>

bool CheckPalindrom(const char* str);
int main() {
	char* word = "helleh";
	bool isPal = CheckPalindrom(word);

	printf("%d", isPal);


	return 0;
}


bool CheckPalindrom(const char* str) {
	int length = strlen(str);
	int start = 0;
	int end = length - 1;

	while (start < end)
	{
		if (str[start] != str[end]) {
			return false;
		}

		start += 1;
		end -= 1;
	}

	return true;
}