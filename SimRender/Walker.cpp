#include "Walker.h"
#include "MACROS.h"
#include "Util.h"

Walker::Walker(float x, float y) {
    this->x = x;
    this->y = y;
}

void Walker::step() {
	float speed = 1;

    float r = (float) rand() / RAND_MAX;
    if (r < 0.25) {
        x += speed;
    }
    else if (r < 0.5) {
        x -= speed;
    }
    else if (r < 0.75) {
        y += speed;
    }
    else {
        y -= speed;
    }

    constrain(&x, 0, WIDTH - 1);
    constrain(&y, 0, HEIGHT - 1);
}