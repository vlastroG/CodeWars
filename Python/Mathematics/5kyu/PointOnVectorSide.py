def point_vs_vector(point, vector):
    k, b, to_right = find_linear(vector[0], vector[1])
    function_value = round(k * point[0] + b, 8)
    point_y = point[1]
    if point_y < function_value:
        return 1 if to_right else -1
    elif point_y == function_value:
        return 0
    else:
        return -1 if to_right else 1


def find_linear(point1, point2):
    k = (point2[1] - point1[1]) / (point2[0] - point1[0])
    b = point1[1] - point1[0] * (point2[1] - point1[1]) / (point2[0] - point1[0])
    return k, b, point2[0] > point1[0]


# solution with cross product
# def point_vs_vector(point, vector):
#     [ax, ay], [bx, by] = vector
#     x, y = point
#     cross = (bx - ax) * (y - ay) - (by - ay) * (x - ax)
#     return (cross < 0) - (cross > 0)


vector = [[1201, 9120], [939, 8807]]
point = -179317, -206537
print(point_vs_vector(point, vector))
