import { PostcurriculumArea } from './postcurriculumArea.interface';

export interface AreaRequirements {
  postCurriculumAreaList: PostcurriculumArea[];
  totalMandatedHours: string;
  totalMaximumHours: string;
  isGeneralAreaList: boolean;
}
