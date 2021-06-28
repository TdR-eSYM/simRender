#include <time.h>
#include <iostream>
#include "Walker.cpp" //I KNOW YOU SHOULD NOT INCLUDE CPP FILES BUT I'M STUPID AND I DON'T SEE WHAT'S WRONG PLEASE POINT IT OUT :(
#include "MACROS.h"
#include "Util.cpp"
#include "Walker.h"

Walker walkers[WALKER_NUM];

int main()
{
	// Intitialize pseudo-random number generator
	srand(time(nullptr));

	for (int i = 0; i < WALKER_NUM; i++) {
		walkers[i] = Walker(random(0, WIDTH - 1), random(0, HEIGHT - 1));
	}
}