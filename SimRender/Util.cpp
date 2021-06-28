#include "Util.h"

void constrain(float* val, float min, float max) {
	if (*val < min) *val = min;
	if (*val > max) *val = max;
}

int random(int min, int max) {
	return rand() % (max - min + 1) + min;;
}