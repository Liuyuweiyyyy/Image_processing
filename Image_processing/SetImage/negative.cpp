#include "pch.h"
extern "C" __declspec(dllexport)
void negative(int* img, int size) {
	for (int i = 0; i < size; i++)
		img[i] = 255 - img[i];
}