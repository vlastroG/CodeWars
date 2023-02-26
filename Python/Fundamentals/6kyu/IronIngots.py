def calc_fuel(ingots_count):
    time = ingots_count * 11

    (time, lava) = calc_fuel_item(time, "lava")
    (time, blaze_rod) = calc_fuel_item(time, "blaze_rod")
    (time, coal) = calc_fuel_item(time, "coal")
    (time, wood) = calc_fuel_item(time, "wood")
    (time, stick) = calc_fuel_item(time, "stick")
    return {
        "lava": lava,
        "blaze rod": blaze_rod,
        "coal": coal,
        "wood": wood,
        "stick": stick
    }


def calc_fuel_item(time_left, fuel_name):
    fuel_time = {
        "lava": 800,
        "blaze_rod": 120,
        "coal": 80,
        "wood": 15,
        "stick": 1
    }
    fuel = int(time_left / fuel_time[fuel_name])
    time_left -= fuel * fuel_time[fuel_name]
    return time_left, fuel
