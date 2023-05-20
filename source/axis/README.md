# axis
Provides an abstraction of measuring a value of generalized units.

# use case
You have a class representing an object with a measureable weight, i.e. 6.43 kilograms. The containing class would express this as a Value struct with the following values (serialized as JSON):
`{
  "value": {
    "dimension": {
      "unit": {
        "name": "kilogram",
        "symbol": "kg",
        "measure": ""
      },
      "minimumValue": -79228162514264337593543950335m,
      "maximumValue": 79228162514264337593543950335m,
      "originValue": 0m
    },
    "magnitude": 6.43m
  }
}`
