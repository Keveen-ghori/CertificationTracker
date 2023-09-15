import { Observable, catchError, of } from 'rxjs';
import { UserService } from './user.service';

export function appInitializer(
  authService: UserService
): () => Observable<any> {
  // return () => authService.refreshToken();
  return () =>
    authService.refreshToken().pipe(
      // catch error to start app on success or failure
      catchError(() => of())
    );
}
