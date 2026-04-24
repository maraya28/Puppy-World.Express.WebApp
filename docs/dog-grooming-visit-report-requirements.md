# Dog Grooming Visit Report Requirements

## 1. Functional Requirements

| Requirement ID | Description |
|---|---|
| FR-01 | Allow the dog grooming owner to view a monthly report of pet visits. |
| FR-02 | Display the date of each visit within the selected month. |
| FR-03 | Show the type of service provided for each visit (e.g. cut, wash, trim). |
| FR-04 | Display the total cost of each visit's services. |
| FR-05 | Provide a monthly total cost summary for all visits. |
| FR-06 | Allow the owner to select the reporting month. |
| FR-07 | Filter or group visits by service type if needed. |
| FR-08 | Present the report in a clear, readable format suitable for business review. |

## 2. Non-Functional Requirements

| Category | Requirement |
|---|---|
| Usability | The report must be easy to read and understand for a grooming salon owner. |
| Performance | Monthly report generation should load within 2-3 seconds for a typical dataset. |
| Reliability | The monthly totals and visit details must be accurate and consistent. |
| Security | Only authenticated salon owners should access the visit report. |
| Scalability | The report should support an increasing number of pet visits without significant degradation. |
| Maintainability | The report module should be easy to update when new service types are added. |

## 3. User Story

**As a** dog grooming salon owner,

**I want** to review a monthly summary of pet visits showing each service type and total service cost,

**so that** I can understand revenue and service usage for the month.

### Acceptance Criteria

- Given I am authenticated as the salon owner, when I select a month, then I can see every pet visit for that month.
- Given a pet visit has multiple services, when the report displays the visit, then it shows each service type and the total cost for that visit.
- Given multiple visits occur in the selected month, when the report is shown, then it displays the monthly total cost across all visits.

## 4. Happy Path Scenario

1. The owner logs in to the system.
2. The owner navigates to the monthly visit report page.
3. The owner selects the desired month.
4. The system retrieves all pet visits for that month.
5. The report displays each visit date, the service type(s) provided, and the total cost for each visit.
6. The report also displays the aggregated total cost for the month.

## 5. Alternate Paths and Edge Cases

- If there are no visits in the selected month, the report should show a message such as "No visits found for this month." and a monthly total of $0.
- If a visit includes more than one service type, the report should list all service types and still compute the correct total cost.
- If the selected month is in the future, the report should show no visits and indicate that future data is unavailable.
- If the report query fails, the system should show a clear error message and allow the owner to retry.
- If service pricing changes after visits are recorded, the report should use the cost stored with each visit rather than current price settings.
