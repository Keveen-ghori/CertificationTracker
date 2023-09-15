import { Injectable } from '@angular/core';
import { ApiResponse } from '../interfaces/apiResponse.interface';
import { Observable, map } from 'rxjs';
import {
  HttpClient,
  HttpErrorResponse,
  HttpHeaders,
  HttpResponse,
} from '@angular/common/http';
import { environment } from 'src/environments/environment.development';
import { FilterValue } from '../interfaces/courseArea.filter.interface';
import { AreaDetails } from '../interfaces/areaDetails.interface';

@Injectable({
  providedIn: 'root',
})
export class POSTCourseAreaService {
  constructor(private httpClient: HttpClient) {}

  ConfigurePostAreas(model: FilterValue): Observable<ApiResponse> {
    return this.httpClient
      .get<ApiResponse>(
        `${environment.TRACKER_API}/ConfigurePOSTAreas/ConfigurePOSTAreas?IncludeArchived=${model.IncludeArchived}&pagesize=${model.pagesize}&currentpage=${model.currentPage}&SortColumn=${model.SortColumn}&SearchString=${model.SearchString}&ShortOrder=${model.ShortOrder}`,
        {
          headers: new HttpHeaders({
            'Content-Type': 'application/json',
            'Access-Control-Allow-Credentials': 'true',
          }),
          withCredentials: true,
        }
      )
      .pipe(map((response: ApiResponse) => response));
  }

  CourseAreaRequirements = (ControlType: string): Observable<ApiResponse> => {
    return this.httpClient
      .get<ApiResponse>(
        `${environment.TRACKER_API}/ConfigurePOSTAreas/RequirementDetail/CurriculumAreaList?ControlType=${ControlType}`,
        {
          headers: new HttpHeaders({
            'Content-Type': 'application/json',
            'Access-Control-Allow-Credentials': 'true',
          }),
          withCredentials: true,
        }
      )
      .pipe(map((response: ApiResponse) => response));
  };

  AreaDetails = (POSTAreaID: number): Observable<ApiResponse> => {
    return this.httpClient
      .get<ApiResponse>(
        `${environment.TRACKER_API}/ConfigurePOSTAreas/POSTAreaDetails?POSTAreaID=${POSTAreaID}`,
        {
          headers: new HttpHeaders({
            'Content-Type': 'application/json',
            'Access-Control-Allow-Credentials': 'true',
          }),
          withCredentials: true,
        }
      )
      .pipe(map((response: ApiResponse) => response));
  };

  SaveAreaDetails = (areaDetails: AreaDetails): Observable<ApiResponse> => {
    return this.httpClient
      .post<ApiResponse>(
        `${environment.TRACKER_API}/ConfigurePOSTAreas/SavePOSTAreaDetail`,
        areaDetails,
        {
          headers: new HttpHeaders({
            'Content-Type': 'application/json',
            'Access-Control-Allow-Credentials': 'true',
          }),
          withCredentials: true,
        }
      )
      .pipe(map((response: ApiResponse) => response));
  };

  DeleteAreaDetails = (areaID: number): Observable<ApiResponse> => {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
    });

    const options = {
      headers: headers,
      withCredentials: true,
    };

    return this.httpClient
      .post<ApiResponse>(
        `${environment.TRACKER_API}/ConfigurePOSTAreas/DeletePOSTArea?POSTAreaID=${areaID}`,
        null,
        options
      )
      .pipe(map((response: ApiResponse) => response));
  };
}
