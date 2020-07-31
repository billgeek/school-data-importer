# 1.0.0.1 - 2020-07-31

## Useability Changes and Bug Fixes

### Added
- Added "Child Information" and "Child Type" columns to allow more flexible filtering, for example: Finding the Parents of Learners in a particular grade or class.
- Learner Grades, Classes, Houses and Hostels are now populated for Parent rows to allow more flexible filtering, for example: Finding the Parents of Learners in a particular grade or class that all belong to the same Hostel.
- Added a checkbox labelled `Only valid numbers` which will prevent rows with less than 10 digits for a Mobile Number to be added to the result list

### Changed
- Filter elements now close automatically when a different filter element is selected. In other words: Only one filter element and/or field is visible at a time.
- The Category (Other Staff Type) and Governing Body columns are now seperated as there were issues attempting to filter on these fields.
- When Learner elements only have either a Grade or a Class, displaying this value is now updated. For example: If a Learner only has Class 1A without a Grade, the user will now see `1A` instead of `Gr. / 1A` in the respective column.
- When the `Parent` or `Learner` items are selected under the `Type` filter object, the `Other Staff` and `Governing Body` filter elements are now disabled and the "Unassigned" option selected.
- When the `Staff` item is selected under the `Type` filter object, the `Grades / Classes`, `Houses` and `Hostels` filter elements are now disabled and the "Unassigned" option selected where applicable. Note that the Grade / Classes filter is completely ignored in this scenario.

### Fixed
- The progress bar on the initial form now no longer disappears after loading the learner data.
- Renamed the output column from `MobileNumber` to `Mobile`


## Developer Changes

### Added
- Implemented a Model Mapping method in the `DataMapper` class to simplify mapping from the model to the data row required on the UI.
- All classes inherited from `BaseModel` now need to implement the method `GetItemIdentifier` in order to load the data into the grid correctly.
- All classes inherited from `BaseModel` now need to implement the method `GetModelMap` to assist in mapping between the model object and the required data row string array. (this was causing issues when adding a new field other than at the end of the required columns)
- Implemented a `MappingHelper` class to assist when performing string operations such as concatenating the Grade and Class values into a single value. This may be replaced in future.

### Changed
- Removed the NSIS Setup script that bundles the .NET Framework installer. Users will now have to download and install the required prerequisites manually.
- Moved hard-coded model names into constants which forms a type of foundation should localization / translation be required in future.
- Moved a lot of string literals into the `AppConstants` class to prevent inadvertently referencing incorrect values. This is not complete and there are still hard-coded references present.
