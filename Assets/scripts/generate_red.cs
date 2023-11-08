using UnityEngine;

public class generate_red : MonoBehaviour
{
   public GameObject voxelPrefab;
    public float range = 1.0f;
    public float increament = 0.5f;
   public void Start()
   {
     CreateVoxels();
   }
   public void CreateVoxels()
   {
        for (float x = -range; x <= range; x+=increament)
        {
            for (float y = -range; y <= range; y+=increament)
            {
                for (float z = -range; z <= range; z+=increament)
                {
                    GameObject voxel = Instantiate(voxelPrefab, new Vector3(x,y,z), Quaternion.identity);
                    voxel.transform.localScale = new Vector3(increament,increament,increament);
                    voxel.transform.parent = transform;
                }
            }
        }
   }
}
