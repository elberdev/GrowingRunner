using UnityEngine;


	public class GrowAndShrink : MonoBehaviour
	{
		

		
		[SerializeField]
		private float m_scaleSpeed = 10.0f;
		
		[SerializeField]
		private Vector3 m_minSize = new Vector3(1.0f, 1.0f, 1.0f);
		
		[SerializeField]
		private Vector3 m_maxSize = new Vector3(4f,4f,4f);
		
		private Vector3 m_targetScale;

		private bool big;
		
		
		private void Update()
		{
			
			
			
			if (Input.GetKeyDown (KeyCode.A)) {
				
				if(big){
					Shrink();
				} else {
					Grow ();
				}
				
			}
			
		}
		
		void Grow()
		{
			//m_transform.localScale = Vector3.Lerp(m_transform.localScale, m_maxSize,  Time.deltaTime * m_scaleSpeed);
			transform.localScale = m_maxSize;
			big = true;
		}
		
		void Shrink()
		{
			//m_transform.localScale = Vector3.Lerp(m_transform.localScale, m_minSize,  Time.deltaTime * m_scaleSpeed);
			transform.localScale = m_minSize;
			big = false;
		}

	}

