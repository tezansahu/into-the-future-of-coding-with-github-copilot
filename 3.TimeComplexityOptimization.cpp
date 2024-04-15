#include <iostream>
#include <vector>

std::vector<std::vector<int>> findTriplets(std::vector<int>& nums) {
    std::vector<std::vector<int>> triplets;
    int n = nums.size();

    for (int i = 0; i < n - 2; i++) {
        for (int j = i + 1; j < n - 1; j++) {
            for (int k = j + 1; k < n; k++) {
                if (nums[i] + nums[j] + nums[k] == 0) {
                    triplets.push_back({nums[i], nums[j], nums[k]});
                }
            }
        }
    }

    return triplets;
}

int main() {
    std::vector<int> nums = {1, -2, 3, -4, 5, -6, 7};
    std::vector<std::vector<int>> result = findTriplets(nums);

    for (const auto& triplet : result) {
        for (const auto& num : triplet) {
            std::cout << num << " ";
        }
        std::cout << std::endl;
    }

    return 0;
}