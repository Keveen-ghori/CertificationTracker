import {
  Component,
  ElementRef,
  OnDestroy,
  OnInit,
  Renderer2,
} from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  FormGroup,
  ValidationErrors,
  Validators,
} from '@angular/forms';
import {
  DialogService,
  DynamicDialogConfig,
  DynamicDialogRef,
} from 'primeng/dynamicdialog';
import { Subject, takeUntil } from 'rxjs';
import { ApiResponse } from 'src/app/core/interfaces/apiResponse.interface';
import { ActionButtons } from 'src/app/core/interfaces/courseConfiguration/actionbuttons.interface';
import { CourseConfigurations } from 'src/app/core/interfaces/courseConfiguration/courseConfigurations.interface';
import { CourseTrainingDetail } from 'src/app/core/interfaces/courseConfiguration/courseTrainingDetail.interface';
import { POSTCourseService } from 'src/app/core/services/course.service';

@Component({
  selector: 'course-details',
  templateUrl: './courseDetailDialog.container.html',
  styleUrls: ['./courseDetailDialog.container.css'],
})
export class CourseDetailDialog implements OnInit, OnDestroy {
  private destroy$: Subject<void> = new Subject<void>();

  courseID!: number;

  cloneCourseID!: number;

  actionButtons: ActionButtons[] = [
    {
      label: 'Save and Close',
      icon: 'pi pi-save',
      type: 'submit',
      visible: true,
    },
    {
      label: 'Add Areas',
      icon: 'pi pi-hashtag',
      type: 'submit',
      visible: false,
    },
    {
      label: 'Confirm All Student',
      icon: 'pi pi-verified',
      type: 'submit',
      visible: false,
    },
    {
      label: 'Edit Student Credit',
      icon: 'pi pi-file-edit',
      type: 'submit',
      visible: false,
    },
    {
      label: 'Save',
      icon: 'pi pi-save',
      type: 'submit',
      visible: false,
    },
    {
      label: 'Clone And Continue',
      icon: 'pi pi-save',
      type: 'submit',
      visible: false,
    },
    {
      label: 'Cancel',
      icon: 'pi pi-times',
      type: 'button',
      visible: true,
    },
  ];

  courseConfigurations!: CourseConfigurations;

  courseConfigurationsForm!: FormGroup;

  showApplicableAreaTable: boolean = false;

  isOutsideDepartment: boolean = false;

  submitted = false;

  invalidDate: string = '';

  isPostApplicableAreaListReadOnly!: boolean;

  isEmployeesDeleted: boolean = false;

  confirmSave: boolean = false;

  // POSTCourseID!: number;

  isValidForConfirmStudent: boolean = false;

  confirmTrainingRecords: boolean = false;

  studentsData: CourseTrainingDetail = {
    pOSTCourseID: 0,
    employees: '',
    attendanceHours: 0,
  };

  confirmEdit: boolean = false;

  confirmStudentBtn: boolean = false;

  editCreditsBtn: boolean = false;

  isValidCourseAtServer: boolean = false;

  constructor(
    public ref: DynamicDialogRef,
    public config: DynamicDialogConfig,
    private courseService: POSTCourseService,
    private formBuilder: FormBuilder,
    private el: ElementRef,
    public dialogService: DialogService
  ) {}

  ngOnInit(): void {
    this.courseID = this.config.data?.courseID;
    this.cloneCourseID = this.config.data?.cloneCourseID;

    this.courseService
      .CourseDetails(this.courseID, this.cloneCourseID)
      .pipe(takeUntil(this.destroy$))
      .subscribe((response: ApiResponse) => {
        this.courseConfigurations = response.content;
        this.isOutsideDepartment =
          this.courseConfigurations.inSideLocation ?? false;

        if (
          this.courseConfigurations.postCourseID != null &&
          this.courseConfigurations.postCourseID != 0
        ) {
          this.showApplicableAreaTable = true;
          this.actionButtons[0].visible = true;
          this.actionButtons[4].visible = true;
          this.actionButtons[1].visible = false;
        } else {
          this.showApplicableAreaTable = false;
          this.actionButtons[1].visible = true;
        }
        if (
          this.courseConfigurations.mainCourseIDOfClone != null &&
          this.courseConfigurations.mainCourseIDOfClone != 0
        ) {
          this.actionButtons[5].visible = true;
          this.isPostApplicableAreaListReadOnly = true;
          this.actionButtons[0].visible = false;
          this.actionButtons[1].visible = false;
        }
        var endDate;
        if (
          this.courseConfigurations.endDate?.toString() &&
          Date.parse(this.courseConfigurations.endDate?.toString())
        ) {
          endDate = new Date(this.courseConfigurations.endDate?.toString());
        }
        debugger;
        if (
          this.courseConfigurations.postApplicableAreaDetails.length !== 0 &&
          this.courseConfigurations.employeeDetail.length !== 0 &&
          endDate != null &&
          endDate < new Date() &&
          this.isPostApplicableAreaListReadOnly
        ) {
          this.actionButtons[2].visible = true;
          this.actionButtons[3].visible = true;
          this.showApplicableAreaTable = true;
        }
      });

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

    setTimeout(() => {
      this.setValue();
    }, 500);
  }

  get f() {
    return this.courseConfigurationsForm.controls;
  }

  setValue() {
    const startDateString =
      this.courseConfigurations?.startDate?.toString() ?? '';
    const endDateString = this.courseConfigurations?.endDate?.toString() ?? '';
    let startDate: Date | null = null;
    let endDate: Date | null = null;

    if (startDateString && Date.parse(startDateString)) {
      startDate = new Date(startDateString);
    }
    if (endDateString && Date.parse(endDateString)) {
      endDate = new Date(endDateString);
    }

    this.courseConfigurationsForm.patchValue({
      courseTitle: this.courseConfigurations.courseTitle,
      sponsor: this.courseConfigurations.sponsor,
      startDate: startDate,
      endDate: endDate,
      courseHours: this.courseConfigurations.courseHours ?? 0,
      courseFee: this.courseConfigurations.courseFee ?? 0,
      inSideLocation: this.courseConfigurations.inSideLocation,
      addressName: this.courseConfigurations.addressName,
      street: this.courseConfigurations.street,
      city: this.courseConfigurations.city,
      state: this.courseConfigurations.state,
      zip: this.courseConfigurations.zip,
      comment: this.courseConfigurations.comment,
      employeeDetail: this.employeeDetailsPatchValue(),
    });

    this.isOutsideDepartment = !(
      this.courseConfigurations.inSideLocation ?? true
    );
  }

  employeeDetailsPatchValue = () => {
    return this.courseConfigurations.lstEmployees.filter((em: any) => {
      return this.courseConfigurations.listEmployee.includes(Number(em.value));
    });
  };

  onSubmit(flag: string) {
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

      return;
    } else {
      if (this.confirmSave) {
        const startDateString =
          this.courseConfigurationsForm.get('startDate')?.value;
        const startDateObject = new Date(startDateString);

        const startDateObjectyear = startDateObject.getFullYear();
        const startDateObjectmonth = String(
          startDateObject.getMonth() + 1
        ).padStart(2, '0');
        const startDateObjectday = String(startDateObject.getDate()).padStart(
          2,
          '0'
        );

        const formattedStartDate = new Date(
          `${startDateObjectyear}-${startDateObjectmonth}-${startDateObjectday}`
        );

        const endDateString =
          this.courseConfigurationsForm.get('endDate')?.value;
        const endDateObject = new Date(endDateString);

        const endDateObjectyear = endDateObject.getFullYear();
        const endDateObjectmonth = String(
          endDateObject.getMonth() + 1
        ).padStart(2, '0');
        const endDateObjectday = String(endDateObject.getDate()).padStart(
          2,
          '0'
        );

        const formattedEndDate = `${endDateObjectyear}-${endDateObjectmonth}-${endDateObjectday}`;

        this.courseConfigurations.courseTitle =
          this.courseConfigurationsForm.get('courseTitle')?.value;
        this.courseConfigurations.sponsor =
          this.courseConfigurationsForm.get('sponsor')?.value ?? '';
        this.courseConfigurations.startDate = formattedStartDate;
        this.courseConfigurations.endDate = new Date(formattedEndDate);
        this.courseConfigurations.courseHours =
          this.courseConfigurationsForm.get('courseHours')?.value ?? 0;
        this.courseConfigurations.courseFee =
          this.courseConfigurationsForm.get('courseFee')?.value;
        this.courseConfigurations.inSideLocation = !this.isOutsideDepartment;
        this.courseConfigurations.addressName =
          this.courseConfigurationsForm.get('addressName')?.value ?? '';
        this.courseConfigurations.street =
          this.courseConfigurationsForm.get('street')?.value ?? '';
        this.courseConfigurations.city =
          this.courseConfigurationsForm.get('city')?.value ?? '';
        this.courseConfigurations.state =
          this.courseConfigurationsForm.get('state')?.value ?? '';
        this.courseConfigurations.zip =
          this.courseConfigurationsForm.get('zip')?.value ?? '';
        this.courseConfigurations.comment =
          this.courseConfigurationsForm.get('comment')?.value ?? '';
        const employeeDetailValue =
          this.courseConfigurationsForm.get('employeeDetail')?.value;
        this.courseConfigurations.employeeDetail =
          typeof employeeDetailValue === 'string'
            ? employeeDetailValue
            : JSON.stringify(employeeDetailValue) || '';

        this.courseService
          .SavePOSTCourseDetails(this.courseConfigurations)
          .pipe(takeUntil(this.destroy$))
          .subscribe((response: ApiResponse) => {
            this.courseID = response.content;
            console.log(response.content);
            debugger;
            if (flag == 'confirm') {
              if (this.confirmTrainingRecords) {
                this.dialogCloseEvent(true, this.courseID);
              }
            }
            if (flag == 'saveAndClose') {
              this.dialogCloseEvent(true, this.courseID);
            }
            if (flag == 'edit') {
              if (this.confirmEdit) {
                this.EditStudentCredits();
                this.editCreditsBtn = true;
              }
            }
          });
      }
    }
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

  ValidateCourseDetail() {
    const startDate = this.f['startDate'].value;
    const endDate = this.f['endDate'].value;

    if (startDate != '' && endDate != '' && endDate < startDate) {
      return 'Start Date should be less than End Date';
    }
    return '';
  }

  street(control: AbstractControl): ValidationErrors | null {
    const isOutsideDepartment = control.parent?.get('inSideLocation')?.value;
    const street = control.parent?.get('street')?.value;

    if (isOutsideDepartment == false && street == '') {
      return { streetError: 'Please enter Street' };
    }
    return null;
  }

  selectEmployee(event: any) {
    var selectedEmployee = event.value;

    if (
      selectedEmployee.length != 0 &&
      this.courseConfigurations.postApplicableAreaDetails.length != 0 &&
      this.isPostApplicableAreaListReadOnly
    ) {
      this.actionButtons[2].visible = true;
      this.actionButtons[3].visible = true;
    } else {
      this.actionButtons[2].visible = false;
      this.actionButtons[3].visible = false;
    }
  }

  btnName(name: string) {
    if (name == 'Cancel') {
      this.dialogCloseEvent(true);
    }
    if (this.courseConfigurationsForm.status == 'INVALID') {
      return;
    } else {
      if (name == 'Add Areas') {
        this.showApplicableAreaTable = true;
      }
      if (name == 'Save and Close' || name == 'Save') {
        this.checkIfEmployeesDeleted(
          this.courseID ?? 0,
          name == 'Save and Close'
            ? 'saveAndClose'
            : name == 'Save'
            ? 'save'
            : ''
        );
      }
      setTimeout(() => {
        if (this.isEmployeesDeleted == false) {
          this.confirmSave = true;
          if (name == 'Save') {
            this.onSubmit('save');
          }
          if (name == 'Save and Close') {
            this.onSubmit('saveAndClose');
          }
        }
      }, 1000);

      if (name == 'Confirm All Student') {
        // this.onSubmit('confirm');
        this.confirmStudentBtn = true;
      }
      if (name == 'Edit Student Credit') {
        this.onSubmit('edit');
      }
    }
  }

  dialogCloseEvent(confirmation: boolean, data?: any) {
    if (confirmation) {
      this.ref.close(data);
    }
  }
  endDateValidation(event: any) {
    if (
      this.courseConfigurationsForm.get('endDate')?.value != null &&
      this.courseConfigurationsForm.get('endDate')?.value < new Date()
    ) {
      this.actionButtons[2].visible = true;
      this.actionButtons[3].visible = true;
      this.showApplicableAreaTable = true;
    } else {
      this.actionButtons[2].visible = false;
      this.actionButtons[3].visible = false;
      this.showApplicableAreaTable = true;
    }
  }
  btn!: string;

  checkIfEmployeesDeleted(POSTCourseID: number, name: string) {
    if (
      JSON.stringify(this.employeeDetailsPatchValue()) ===
      JSON.stringify(this.courseConfigurationsForm.get('employeeDetail')?.value)
    ) {
      this.isEmployeesDeleted = false;
    } else {
      this.courseService
        .CheckTrainingRecordAvailForEmployee(POSTCourseID)
        .pipe(takeUntil(this.destroy$))
        .subscribe((response: ApiResponse) => {
          debugger;
          this.isEmployeesDeleted = response.content;
          console.log(this.isEmployeesDeleted);
          this.btn = name;
        });
    }
  }

  confirmSaveBtnClick(flag: boolean, btn: string) {
    debugger;
    this.confirmSave = flag;
    if (this.confirmSave) {
      this.onSubmit(btn);
    }
  }

  ConfirmTrainingDetails(flag: boolean, btn: string) {
    debugger;
    this.confirmTrainingRecords = flag;
    this.validateCourseAtServer();
    if (this.confirmTrainingRecords && this.isValidCourseAtServer) {
      this.FinalConfirmTraining();
      this.onSubmit(btn);
    }
  }
  FinalConfirmTraining() {
    debugger;
    this.studentsData.pOSTCourseID = this.courseID;
    this.studentsData.employees =
      this.courseConfigurationsForm.get('employeeDetail')?.value;
    this.studentsData.attendanceHours =
      this.courseConfigurations.attendanceHours !== undefined &&
      this.courseConfigurations.attendanceHours !== null
        ? this.courseConfigurations.attendanceHours
        : this.courseConfigurationsForm.get('courseHours')?.value != null
        ? this.courseConfigurationsForm.get('courseHours')?.value
        : 0;

    this.courseService
      .ConfirmTraining(this.studentsData)
      .pipe(takeUntil(this.destroy$))
      .subscribe((response: ApiResponse) => {
        this.dialogCloseEvent(true);
      });
  }

  confirmEditCredit(flag: boolean, btn: string) {
    this.confirmEdit = flag;
    if (this.isValidCourseAtServer) {
      this.EditStudentCredits();
      this.onSubmit(btn);
    }
  }
  EditStudentCredits() {
    this.studentsData.pOSTCourseID = this.courseID;
    this.studentsData.employees =
      this.courseConfigurationsForm.get('employeeDetail')?.value;
    this.studentsData.attendanceHours =
      this.courseConfigurations.attendanceHours !== undefined &&
      this.courseConfigurations.attendanceHours !== null
        ? this.courseConfigurations.attendanceHours
        : this.courseConfigurationsForm.get('courseHours')?.value != null
        ? this.courseConfigurationsForm.get('courseHours')?.value
        : 0;

    this.courseService
      .SaveCourseWithEmployeeDetail(this.studentsData)
      .pipe(takeUntil(this.destroy$))
      .subscribe((response: ApiResponse) => {
        this.dialogCloseEvent(true);
      });
  }
  errorMessage: string = '';
  validateCourseAtServer() {
    this.courseService
      .validateCourseAtServer(Number(this.courseID))
      .pipe(takeUntil(this.destroy$))
      .subscribe((response: ApiResponse) => {
        this.errorMessage = response.content;
        if (this.errorMessage != '' || this.errorMessage != null) {
          this.isValidCourseAtServer = true;
        }
      });
  }

  ngOnDestroy() {
    this.destroy$.next();
    this.destroy$.complete();
  }
}
