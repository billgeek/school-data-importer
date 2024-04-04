# 1.0.1.7 - 2024-04-04

- When changing any filter selections, the available list will now be hidden. To view the list again, click on "Apply Filters".

# 1.0.1.6 - 2024-04-02

## Useability Changes and Bug Fixes

### Changed
- The "Grades/Classes" filter is no longer available for the Staff category
- The labels for empty values in "Bus Routes", "Hostels" and "Houses" have been updated to "Not in a [bus route / hostel / house]"

### Fixed
- Spouses of Parent entities were still referencing the incorrect status column. All parent entities now make use of `lStatus` as required

# 1.0.1.5 - 2024-03-26

## Useability Changes and Bug Fixes

### Added
- A new column has been introduced for the Learner Nick Name

### Fixed
- When resetting filters, the Status for Unassigned is now also unchecked
- The Parent entity was using the incorrect Status column and has now been rectified

# 1.0.1.4 - 2024-03-25

## Useability Changes and Bug Fixes

### Added
- All filters except Category, Gender and Status now have "All" and "None" buttons
- A new Category (previously "Type") has been added for Governing Body to allow filtering only for governing body members

### Changed
- The "Type" column was changed to "Category" to match the filter name
- The "Add Only Valid Numbers" checkbox is no longer visible and the rule is applied by default
- The "Category" filter (previously "Type") now only allows a single selection and has changed from check boxes to radio buttons
- The Bus Routes filter now selected "Not Applicable / Blank" by default and will not select ALL options
- The checkbox "Only copy highlighted rows" has been changed to "Only copy / export highlighted rows" for clarity
- The total number of rows has been removed from the row indicator (IE: Instead of seeing "10 / 2100 rows" the user will now see "10 rows")
- Filter visibility is now dependent on the type of Category selected. Please refer to the table below for details on which filters apply to which categories.
- The "Staff" filter has now been renamed "Staff Type"
- The "Other Staff Type" column has been removed and the data merged with the "Staff Type" column
- Due to the change in filters hiding based on the selected Category, all Staff Types and Governing Body values are selected by default

### Fixed
- The "Bus Routes" filter now collapses automatically when another filter has been opened
- Other Staff entities (non-educators) were incorrectly marked under the "Parents" category. This has been fixed and now allows other staff members to be included in the "Staff" category.

## Technical Changes
No technical changes were made in this release.

## Filter and Category reference table
The table below indicates which Filters (rows) are applied and are visible to which Categories. (columns)

| Filter | Parent / Learner | Staff | Governing Body |
| --- | :---: | :---: | :---: | 
| Gender | &#10003; | &#10003; |  &#10003; |
| Status | &#10003; | &#10003; |  &#10003; |
| Grades / Classes | &#10003; | &#x274C; |  &#x274C; |
| Bus Routes | &#10003; | &#x274C; |  &#x274C; |
| Houses | &#10003; | &#x274C; |  &#x274C; |
| Hostels | &#10003; | &#x274C; | &#x274C; |
| Staff | &#x274C; | &#10003; | &#x274C; |
| Governing Body | &#x274C; | &#x274C; | &#10003; |


# 1.0.1.1 - 2024-03-18

## Useability Changes and Bug Fixes

### Added
- A Bus Route column was added, along with the appropriate filter option
- A new filter option was introduced to "Show only non-blank cell numbers"

### Changed
- Users are now able to copy and paste a DB file name into the start form instead of being forced to browse for a file. After pasting a value, pressing TAB will trigger the authentication process.
- Users are now able to reorder columns on the data grids. Note that the reordering will only be affected when the "source" list is changed and the same column order will be used for the "selected" grid.
- On the Selected grid, users can now select rows using SHIFT or CTRL and export/copy only the selected rows vs. all rows in the grid.
- Exporting the data now results in the "Child Information" column to be copied into the "merge1" column.
- The "Type" filter now has "Parents" selected as default.

### Fixed
- An "index out of range" exception was thrown when importing certain DB's. This was caused by an incorrect reference to a Combo List control due to a copy and paste error.
- Rows in the grids are now unique - A "Distinct" call was missing on the majority of data elements.

# 1.0.0.3 - 2020-08-02

## Useability Changes and Bug Fixes

### Added
- Tooltips were added to the Export and Copy buttons to assist the user in understanding the action they are about to perform.
- Three additional columns were added to the Excel Export functionality to assist with Merge information.

### Fixed
- The label text for the selected number of rows will now show information consistently.

# 1.0.0.2 - 2020-08-01

## Useability Changes and Bug Fixes

### Added
- The exising "Export" button is renamed to "Copy" (Which will result in the existing functionality of copying the result to the clipboard) and a new button was added called `Export` which will create an Excel file with the result.

### Changed
- The Checkbox for "Only valid numbers" is now checked by default.
- The `Apply Filters` and `Reset Filters` buttons are now docked below the filters instead of the bottom of the window.
- Reordered the columns to show the child Gender and Parent Type next to the Child Information for ease of reference.

### Fixed
- Removed the `MobilePhoneCode` from the Mobile Numbers as this was causing 13 digit numbers.

## Technical Changes

### Added
- New configuration flag (`FetchRemoteQueries`) that will enable or disable reading queries from a remote server. When set to FALSE, the queries will be read from the application storage.
- Added a package reference to `EPPlus` in order to create Excel files.

### Changed
- Changed the `FetchQueryStatmentsLocally` to public in the `QueryStatementEngine`.
- The toggle to display the filter string used will now only be available on Debug builds.


# 1.0.0.1 - 2020-07-31

## Useability Changes and Bug Fixes

### Added
1. Added "Child Information" and "Child Type" columns to allow more flexible filtering, for example: Finding the Parents of Learners in a particular grade or class.
2. Learner Grades, Classes, Houses and Hostels are now populated for Parent rows to allow more flexible filtering, for example: Finding the Parents of Learners in a particular grade or class that all belong to the same Hostel.
3. Added a checkbox labelled `Only valid numbers` which will prevent rows with less than 10 digits for a Mobile Number to be added to the result list

### Changed
1. Filter elements now close automatically when a different filter element is selected. In other words: Only one filter element and/or field is visible at a time.
2. The Category (Other Staff Type) and Governing Body columns are now seperated as there were issues attempting to filter on these fields.
3. When Learner elements only have either a Grade or a Class, displaying this value is now updated. For example: If a Learner only has Class 1A without a Grade, the user will now see `1A` instead of `Gr. / 1A` in the respective column.
4. When the `Parent` or `Learner` items are selected under the `Type` filter object, the `Other Staff` and `Governing Body` filter elements are now disabled and the "Unassigned" option selected.
5. When the `Staff` item is selected under the `Type` filter object, the `Grades / Classes`, `Houses` and `Hostels` filter elements are now disabled and the "Unassigned" option selected where applicable. Note that the Grade / Classes filter is completely ignored in this scenario.

### Fixed
1. The progress bar on the initial form now no longer disappears after loading the learner data.
2. Renamed the output column from `MobileNumber` to `Mobile`

## Technical Changes

### Added
1. Implemented a Model Mapping method in the `DataMapper` class to simplify mapping from the model to the data row required on the UI.
2. All classes inherited from `BaseModel` now need to implement the method `GetItemIdentifier` in order to load the data into the grid correctly.
3. All classes inherited from `BaseModel` now need to implement the method `GetModelMap` to assist in mapping between the model object and the required data row string array. (this was causing issues when adding a new field other than at the end of the required columns)
4. Implemented a `MappingHelper` class to assist when performing string operations such as concatenating the Grade and Class values into a single value. This may be replaced in future.

### Changed
1. Removed the NSIS Setup script that bundles the .NET Framework installer. Users will now have to download and install the required prerequisites manually.
2. Moved hard-coded model names into constants which forms a type of foundation should localization / translation be required in future.
3. Moved a lot of string literals into the `AppConstants` class to prevent inadvertently referencing incorrect values. This is not complete and there are still hard-coded references present.
