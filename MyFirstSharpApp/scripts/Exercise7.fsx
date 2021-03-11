// The goal of this exercise is simply to learn how to create records and init them.

type Car =
	{ Manufacturer: string
      EngineSize: string
      NbDoors: int
      NbWheels: int }

let _car = {
    Manufacturer = "Renault"
    EngineSize = "Small"
    NbDoors = 2
    NbWheels = 4 }
