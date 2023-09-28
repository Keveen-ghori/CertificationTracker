import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiResponse } from '../interfaces/apiResponse.interface';
import { Observable, map } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CourseFilter } from '../interfaces/courseConfiguration/courseFilter.interface';
import { CourseConfigurations } from '../interfaces/courseConfiguration/courseConfigurations.interface';
import { CourseTrainingDetail } from '../interfaces/courseConfiguration/courseTrainingDetail.interface';

@Injectable({
  providedIn: 'root',
})
export class POSTCourseService {
  constructor(private httpClient: HttpClient) {}

  GetCourseList = (model: CourseFilter): Observable<ApiResponse> => {
    return this.httpClient
      .post<ApiResponse>(
        `${environment.TRACKER_API}/PostCourseConfiguration/GetCourseList`,
        model,
        {
          headers: new HttpHeaders({
            'content-type': 'application/json',
          }),
          withCredentials: true,
        }
      )
      .pipe(map((response: ApiResponse) => response));
  };

  GetCourseCloneLists = (): Observable<ApiResponse> => {
    return this.httpClient
      .get<ApiResponse>(
        `${environment.TRACKER_API}/PostCourseConfiguration/GetCourseCloneLists`,
        { withCredentials: true }
      )
      .pipe(map((response: ApiResponse) => response));
  };

  CourseDetails = (
    POSTCourseID: number,
    ClonePOSTCourseID: number
  ): Observable<ApiResponse> => {
    return this.httpClient
      .get<ApiResponse>(
        `${environment.TRACKER_API}/PostCourseConfiguration/CourseDetails?POSTCourseID=${POSTCourseID}&ClonePOSTCourseID=${ClonePOSTCourseID}`,
        { withCredentials: true }
      )
      .pipe(map((response: ApiResponse) => response));
  };

  SavePOSTCourseDetails = (
    courseConfigurations: CourseConfigurations
  ): Observable<ApiResponse> => {
    debugger;
    return this.httpClient
      .post<ApiResponse>(
        `${environment.TRACKER_API}/PostCourseConfiguration/SavePOSTCourseDetails`,
        courseConfigurations,
        { withCredentials: true }
      )
      .pipe(map((response: any) => response));
  };

  CheckTrainingRecordAvailForEmployee = (
    POSTCourseID: number
  ): Observable<ApiResponse> => {
    return this.httpClient
      .get<ApiResponse>(
        `${environment.TRACKER_API}/PostCourseConfiguration/CheckTrainingRecordAvailForEmployee?POSTCourseID=${POSTCourseID}`,
        { withCredentials: true }
      )
      .pipe(map((response: any) => response));
  };

  ConfirmTraining = (
    studentsData: CourseTrainingDetail
  ): Observable<ApiResponse> => {
    debugger;
    return this.httpClient
      .post<ApiResponse>(
        `${environment.TRACKER_API}/PostCourseConfiguration/ConfirmTraining`,
        studentsData,
        { withCredentials: true }
      )
      .pipe(map((response: any) => response));
  };

  SaveCourseWithEmployeeDetail = (
    studentsData: CourseTrainingDetail
  ): Observable<ApiResponse> => {
    debugger;
    return this.httpClient
      .post<ApiResponse>(
        `${environment.TRACKER_API}/PostCourseConfiguration/SaveCourseWithEmployeeDetail`,
        studentsData,
        { withCredentials: true }
      )
      .pipe(map((response: any) => response));
  };

  validateCourseAtServer = (POSTCourseID: number): Observable<ApiResponse> => {
    debugger;
    return this.httpClient
      .get<ApiResponse>(
        `${environment.TRACKER_API}/PostCourseConfiguration/ValidateCourseAtServer?POSTCourseID=${POSTCourseID}`,
        { withCredentials: true }
      )
      .pipe(map((response: any) => response));
  };
}
