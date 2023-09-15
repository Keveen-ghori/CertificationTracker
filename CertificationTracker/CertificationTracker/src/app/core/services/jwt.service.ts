import { Injectable } from "@angular/core";

@Injectable({ providedIn: "root" })
export class JwtService {
  private secret = 'ByYM000OLlMQG6VVVp1OH7Xzyr7gHuw1qvUC5dcGt3SNM';


  getToken(): string {
    return window.localStorage["jwtToken"];
  }

  saveToken(token: string): void {
    window.localStorage["jwtToken"] = token;
  }

  destroyToken(): void {
    window.localStorage.removeItem("jwtToken");
  }
  
}