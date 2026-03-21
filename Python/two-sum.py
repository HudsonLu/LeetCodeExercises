def two_sum(nums, target):
    i = 0
    while i < len(nums):
        y = target - nums[i]

        j = 0
        while j < len(nums):
            if i != j and y == nums[j]:
                return [i, j]
            j += 1

        i += 1

    return None


nums = [2, 7, 11, 15]
target = 80

x = two_sum(nums, target)

if x is not None:
    print(x[0], x[1])
else:
    print("No solution found")