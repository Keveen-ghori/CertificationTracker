import { Component, ElementRef, OnDestroy, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  FormGroup,
  ValidationErrors,
  Validators,
} from '@angular/forms';
import { DynamicDialogConfig } from 'primeng/dynamicdialog';
import { Subject, takeUntil } from 'rxjs';
import { containsAll } from 'src/app/core/Constants/containsAll';
import { ApiResponse } from 'src/app/core/interfaces/apiResponse.interface';
import { CourseConfigurations } from 'src/app/core/interfaces/courseConfiguration/courseConfigurations.interface';
import { POSTCourseService } from 'src/app/core/services/course.service';

@Component({
  selector: 'course-details',
  templateUrl: './courseDetailDialog.container.html',
  styleUrls: ['./courseDetailDialog.container.css'],
})
export class CourseDetailDialog implements OnInit, OnDestroy {
  private destroy$: Subject<void> = new Subject<void>();

  POSTCourseID: number = 0;

  ClonePOSTCourseID: number = 0;

  courseDetails!: CourseConfigurations;

  courseConfigurationsForm!: FormGroup;

  invalidDate: string = '';

  submitted: boolean = false;

  isOutsideDepartment: boolean = false;

  isPostApplicableAreaListReadOnly: boolean = false;

  showApplicableAreaTable: boolean = false;

  isValid: boolean = true;

  errorMessage: string = '';

  AttendanceHours: number = 0;

  showBtnSaveAndExitCourseDetails: boolean = false;

  showApplicableAreasTable: boolean = false;

  showBtnSaveCourseDetails: boolean = false;

  showBtnConfirmCourseDetails: boolean = false;
  showBtnEditStudentCredits: boolean = false;

  showBtnAddAreas: boolean = false;

  showBtnClone: boolean = false;

  isValidCourseDetails: boolean = true;

  isValidConfirmDetails: boolean = false;

  validateCourseAtServer: boolean = false;

  isEmployeesDeleted: boolean = false;

  isCourseDetailsValid: boolean = false;

  constructor(
    private courseService: POSTCourseService,
    public config: DynamicDialogConfig,
    private formBuilder: FormBuilder,
    private el: ElementRef
  ) {}

  ngOnInit(): void {
    this.courseDetails = this.config.data?.CourseDetails;

    this.ClonePOSTCourseID = this.courseDetails.mainCourseIDOfClone;
    this.POSTCourseID = this.courseDetails.postCourseID;
    this.AttendanceHours = this.courseDetails.attendanceHours ?? 0;

    this.courseConfigurationsForm = this.formBuilder.group({
      courseTitle: ['', Validators.required],
      sponsor: [''],
      startDate: ['', Validators.required],
      endDate: ['', Validators.required],
      courseHours: ['', Validators.required],
      courseFee: [0, Validators.required],
      inSideLocation: [true, Validators.required],
      addressName: [''],
      street: ['', this.street.bind(this)],
      city: [''],
      state: [''],
      zip: [''],
      comment: [''],
      employeeDetail: [''],
    });

    this.patchCourseDetailValues();
    debugger;
    if (this.POSTCourseID != 0 && this.POSTCourseID != null) {
      this.showApplicableAreaTable = true;
      this.showBtnSaveAndExitCourseDetails = true;
      this.showBtnSaveCourseDetails = true;
    } else {
      this.showApplicableAreaTable = false;
      this.showBtnAddAreas = true;
      this.showBtnSaveAndExitCourseDetails = true;
    }

    if (this.ClonePOSTCourseID != 0 && this.ClonePOSTCourseID != null) {
      this.isPostApplicableAreaListReadOnly = true;
      this.showBtnClone = true;
      this.showBtnAddAreas = false;
      this.showBtnSaveAndExitCourseDetails = false;
    }

    setTimeout(() => {
      this.ValidateConfirmTraining();
    }, 150);
  }

  get f() {
    return this.courseConfigurationsForm.controls;
  }

  patchCourseDetailValues = () => {
    debugger;
    const startDateString = this.courseDetails?.startDate?.toString() ?? '';
    const endDateString = this.courseDetails?.endDate?.toString() ?? '';
    let startDate: Date | null = null;
    let endDate: Date | null = null;

    if (startDateString && Date.parse(startDateString)) {
      startDate = new Date(startDateString);
    }
    if (endDateString && Date.parse(endDateString)) {
      endDate = new Date(endDateString);
    }

    this.courseConfigurationsForm.patchValue({
      courseTitle: this.courseDetails.courseTitle,
      sponsor: this.courseDetails.sponsor,
      startDate: startDate,
      endDate: endDate,
      courseHours: this.courseDetails.courseHours ?? 0,
      courseFee: this.courseDetails.courseFee ?? 0,
      inSideLocation: !this.isOutsideDepartment,
      addressName: this.courseDetails.addressName,
      street: this.courseDetails.street,
      city: this.courseDetails.city,
      state: this.courseDetails.state,
      zip: this.courseDetails.zip,
      comment: this.courseDetails.comment,
      employeeDetail: this.employeeDetailsPatchValue(),
    });
    console.log(this.courseDetails.listEmployee);

    this.isOutsideDepartment = !(this.courseDetails.inSideLocation ?? true);
  };

  employeeDetailsPatchValue = () => {
    return this.courseDetails.lstEmployees.filter((em: any) => {
      return this.courseDetails.listEmployee.includes(Number(em.value));
    });
  };

  ValidateConfirmTraining() {
    var courseStartDate =
      this.courseConfigurationsForm.get('startDate')?.value ?? '';
    var courseEndDate =
      this.courseConfigurationsForm.get('endDate')?.value ?? '';
    var courseSDate = new Date(courseStartDate);
    var courseEDate = new Date(courseEndDate);

    if (courseStartDate != '' && courseEndDate == '') {
      this.courseConfigurationsForm.patchValue({ endDate: courseSDate });
    } else if (courseStartDate == '' && courseEndDate != '') {
      this.courseConfigurationsForm.patchValue({ startDate: courseEDate });
    }

    if (
      courseStartDate == '' ||
      courseEndDate == '' ||
      (courseStartDate != '' &&
        courseEndDate != '' &&
        courseEDate < courseSDate) ||
      this.courseConfigurationsForm.get('courseHours')?.value == null ||
      this.courseConfigurationsForm.get('courseHours')?.value == '0'
    ) {
      this.isValidCourseDetails = false;
    }

    var selectedItem_POSTEmployees =
      this.courseConfigurationsForm.get('employeeDetail')?.value;
    this.courseService
      .validateCourseAtServer(this.courseDetails.postCourseID)
      .pipe(takeUntil(this.destroy$))
      .subscribe((response: ApiResponse) => {
        this.errorMessage = response.content;

        if (this.errorMessage == '') {
          this.validateCourseAtServer = true;
          this.isValid = true;
        }

        if (this.isValidCourseDetails) {
          var endDate = this.courseConfigurationsForm.get('endDate')?.value;
          var eDate = new Date(endDate);
          var currentDate = new Date();
          currentDate.setHours(0, 0, 0, 0);
          if (
            eDate <= currentDate &&
            this.courseDetails.postCourseID.toString() != '0' &&
            (this.isValid ||
              (!this.isValid &&
                this.errorMessage ==
                  'Please select Employee before confirm training')) &&
            selectedItem_POSTEmployees.length != null &&
            selectedItem_POSTEmployees != undefined &&
            selectedItem_POSTEmployees.length > 0
          ) {
            this.isValidConfirmDetails = true;
          } else {
            this.isValidConfirmDetails = false;
          }
        }

        if (this.isValidConfirmDetails) {
          this.showBtnConfirmCourseDetails = true;
          this.showBtnEditStudentCredits = true;
        } else {
          this.showBtnConfirmCourseDetails = false;
          this.showBtnEditStudentCredits = false;
        }
      });
  }

  // street(control: AbstractControl): Promise<ValidationErrors | null> {
  //   debugger;
  //   const isOutsideDepartment = control.parent?.get('inSideLocation')?.value;
  //   const street = control.parent?.get('street')?.value;

  //   return new Promise((resolve) => {
  //     setTimeout(() => {
  //       if (isOutsideDepartment == false && street == '') {
  //         resolve({ streetError: 'Please enter Street' });
  //       } else {
  //         resolve(null);
  //       }
  //     }, 0);
  //   });
  // }

  street(control: AbstractControl): ValidationErrors | null {
    const isOutsideDepartment = control.parent?.get('inSideLocation')?.value;
    const street = control.parent?.get('street')?.value;

    if (isOutsideDepartment == false && street == '') {
      return { streetError: 'Please enter Street' };
    }
    return null;
  }

  onSubmit = (control: string) => {
    if (this.isCourseDetailsValid) {
    }
  };

  validCourseDetail() {
    debugger;
    this.submitted = true;
    const validationError = this.ValidateCourseDetail();
    if (this.courseConfigurationsForm.invalid) {
      this.invalidDate = validationError;
      for (const key of Object.keys(this.courseConfigurationsForm.controls)) {
        if (this.courseConfigurationsForm.controls[key].invalid) {
          const invalidControl = this.el.nativeElement.querySelector(
            '[formcontrolname="' + key + '"]'
          );
          invalidControl.focus();
          break;
        }
      }
      this.isCourseDetailsValid = false;
    } else this.isCourseDetailsValid = true;
  }

  ValidateCourseDetail() {
    const startDate = this.f['startDate'].value;
    const endDate = this.f['endDate'].value;

    if (startDate != '' && endDate != '' && endDate < startDate) {
      return 'Start Date should be less than End Date';
    }
    return '';
  }

  location(event: any) {
    if (event.target.value == 'inDepartment') {
      this.isOutsideDepartment = false;
    } else {
      this.isOutsideDepartment = true;
    }
    this.courseConfigurationsForm.patchValue({
      inSideLocation: !this.isOutsideDepartment,
    });
  }

  selectEmployee(event: any) {
    this.ValidateConfirmTraining();
  }

  btnSaveAndCloseCourseDetails_Click = () => {
    debugger;
    this.validCourseDetail();
    if (this.isCourseDetailsValid) {
      this.checkIfEmployeesDeleted();
      if (this.isEmployeesDeleted) {
      }
    }
  };

  btnConfirmTraining_Click = () => {
    console.log('btnConfirmTraining_Click');
  };

  btnEditStudentCredits_Click = () => {
    console.log('btnEditStudentCredits_Click');
  };

  btnSaveCourseDetails_Click = () => {
    console.log('btnSaveCourseDetails_Click');
  };

  btnExitCourseDetails_Click = () => {
    console.log('btnExitCourseDetails_Click');
  };

  checkIfEmployeesDeleted() {
    var names = this.courseConfigurationsForm.get('employeeDetail')?.value;
    var lstPOSTEmployees = this.employeeDetailsPatchValue();

    if (containsAll(lstPOSTEmployees, names)) {
      this.isEmployeesDeleted = false;
    } else {
      this.courseService
        .CheckTrainingRecordAvailForEmployee(this.POSTCourseID)
        .pipe(takeUntil(this.destroy$))
        .subscribe((response: ApiResponse) => {
          this.isEmployeesDeleted = response.content;
        });
    }
  }
  ngOnDestroy() {
    this.destroy$.next();
    this.destroy$.complete();
  }
}
